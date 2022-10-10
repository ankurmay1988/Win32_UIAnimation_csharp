using SharpGen.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.AnimationManager;

namespace Sample
{
    internal class TimerControlled
    {
        private IUIAnimationManager2 _manager;
        private IUIAnimationTransitionLibrary2 _transitionLib;
        private IUIAnimationTimer _animationTimer;
        private IUIAnimationVariable2 _variable;
        private List<double> _fpsBucket = new List<double>();
        private int fps = 0;
        private double prev = 0.0;

        public void Run()
        {
            var f = CreateForm();
            SetupTimerControlledAnimation(f);
        }

        private void SetupAnimationObjects(Form f)
        {
            _manager = Factory.CreateAnimationManager2();
            _transitionLib = Factory.CreateAnimationTransitionLibrary2();
            _animationTimer = Factory.CreateAnimationTimer();

            _variable = _manager.CreateAnimationVariable(10);
            var t = _transitionLib.CreateAccelerateDecelerateTransition(1.5, f.DisplayRectangle.Width - 10, 0.8, 0.2);

            var story = _manager.CreateStoryboard();
            story.AddTransition(_variable, t);
            var startKeyframe = story.AddKeyframeAtOffset(-1, 0);
            var endKeyframe = story.AddKeyframeAtOffset(-1, 1.5);

            story.RepeatBetweenKeyframes(startKeyframe, endKeyframe, -1, RepeatMode.Alternate, null, UIntPtr.Zero, true);

            var timestamp = _animationTimer.Time;
            story.Schedule(timestamp);
        }

        private void SetupTimerControlledAnimation(Form f)
        {
            SetupAnimationObjects(f);

            // Disable the animation timer first, because we are connecting
            // Manager and Timer together.
            _animationTimer.Disable();

            // Connect Animation Manager to Timer
            var timerUpdateHandler = _manager.QueryInterface<IUIAnimationTimerUpdateHandlerNative>();
            _animationTimer.SetTimerUpdateHandler(timerUpdateHandler, IdleBehavior.Continue);

            // Implement our IUIAnimationTimerEventHandler 
            var timerEventHandler = new TimerEventHandler(f, g =>
            {
                var timestamp = _animationTimer.Time;
                Draw(g, timestamp);
            });

            // Set to timer
            _animationTimer.SetTimerEventHandler(timerEventHandler);

            // Enable timer
            _animationTimer.Enable();
        }

        private void Draw(Graphics g, double timestamp)
        {
            if (_fpsBucket.Count > 29)
            {
                fps = (int)((fps + Math.Floor(1 / _fpsBucket.Average())) / 2.0f);
                _fpsBucket.Clear();
            }

            _fpsBucket.Add(timestamp - prev);

            var val = _variable.Value;
            g.Clear(Color.Black);
            g.DrawString($"{fps} fps", SystemFonts.StatusFont, Brushes.Red, 10, 10);
            g.FillEllipse(Brushes.Orange, (float)val, 100, (float)val / 10, (float)val / 10);
            prev = timestamp;
        }

        private Form CreateForm()
        {
            var frm = new Form();
            frm.ClientSize = new Size(800, 600);
            frm.Show();
            return frm;
        }
    }

    public class TimerEventHandler : CallbackBase, IUIAnimationTimerEventHandler
    {
        private readonly Form _form;
        private readonly Graphics _formGraphics;
        private readonly BufferedGraphicsContext _bufferedContext;
        private readonly Action<Graphics> _invalidateCall;

        public TimerEventHandler(Form f, Action<Graphics> invalidateAction)
        {
            _form = f;
            _formGraphics = Graphics.FromHwnd(f.Handle);
            _bufferedContext = new BufferedGraphicsContext();
            _invalidateCall = invalidateAction;
        }

        public void OnPostUpdate()
        {
            using var bg = _bufferedContext.Allocate(_formGraphics, _form.DisplayRectangle);
            var g = bg.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            _invalidateCall(g);
            bg.Render();
        }

        public void OnPreUpdate()
        {

        }

        public void OnRenderingTooSlow(uint framesPerSecond)
        {

        }
    }
}
