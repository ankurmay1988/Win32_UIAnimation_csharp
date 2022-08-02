using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Windows.AnimationManager;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var f = CreateForm();
            var man = Factory.CreateAnimationManager2();
            var tl = Factory.CreateAnimationTransitionLibrary2();
            var atimer = Factory.CreateAnimationTimer();

            var v = man.CreateAnimationVariable(10);
            var t = tl.CreateAccelerateDecelerateTransition(1.5, f.DisplayRectangle.Width - 10, 0.8, 0.2);
            
            var fpsBucket = new List<double>();
            int fps = 0;
            double prev = 0;
            var s = atimer.Time;
            
            var story = man.CreateStoryboard();
            story.AddTransition(v, t);
            var startKeyframe = story.AddKeyframeAtOffset(-1, 0);
            var endKeyframe = story.AddKeyframeAtOffset(-1, 1.5);
            //story.AddKeyframeAfterTransition(t, out var endKeyframe);
            
            story.RepeatBetweenKeyframes(startKeyframe, endKeyframe, -1, RepeatMode.Alternate, null, UIntPtr.Zero, true);
            story.Schedule(s);

            RenderLoop(f, bg =>
            {
                while (true)
                {
                    //Console.WriteLine($"Variable Value: {v.GetValue()}");
                    Application.DoEvents();
                    if (f.IsDisposed || man.Status == ManagerStatus.Idle) break;

                    if (fpsBucket.Count > 29)
                    {
                        fps = (int)Math.Floor(1 / fpsBucket.Average());
                        fpsBucket.Clear();
                    }

                    s = atimer.Time;
                    fpsBucket.Add(s - prev);
                    man.Update(s);

                    var val = v.Value;
                    var g = bg.Graphics;
                    g.Clear(Color.Black);
                    g.DrawString($"{fps} fps", SystemFonts.StatusFont, Brushes.Red, 10, 10);
                    g.FillEllipse(Brushes.Orange, (float)val, 100, (float)val / 10, (float)val / 10);
                    bg.Render();
                    prev = s;
                }
            });
        }

        private static void RenderLoop(Form f, Action<BufferedGraphics> draw)
        {
            using Graphics formGraphics = Graphics.FromHwnd(f.Handle);
            using var bgc = new BufferedGraphicsContext();
            using var bg = bgc.Allocate(formGraphics, f.DisplayRectangle);
            var g = bg.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            draw(bg);
        }

        private static Form CreateForm()
        {
            var frm = new Form();
            frm.ClientSize = new Size(800, 600);
            frm.Show();
            return frm;
        }
    }
}
