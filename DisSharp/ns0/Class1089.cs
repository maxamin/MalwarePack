namespace ns0
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.Windows.Forms;

    internal class Class1089 : Button
    {
        protected static int ButtonDefaultWidth = 80;
        protected static int ButtonHeight = 30;
        protected static int ButtonShadowOffset = 5;
        protected ColorMatrix cmDefault;
        protected ColorMatrix cmNormal;
        protected float gamma;
        protected float gammaShift;
        protected ImageAttributes iaDefault;
        protected ImageAttributes iaNormal;
        protected Image imgFill;
        protected Image imgLeft;
        protected Image imgRight;
        protected bool mousePressed;
        protected Point ptMousePosition;
        protected bool pulse;
        protected static float PulseGammaMax = 1.8f;
        protected static float PulseGammaMin = 0.7f;
        protected static float PulseGammaReductionThreshold = 0.2f;
        protected static float PulseGammaShift = 0.2f;
        protected static float PulseGammaShiftReduction = 0.5f;
        protected static int PulseInterval = 70;
        protected Rectangle rcLeft;
        protected Rectangle rcRight;
        protected bool sizeToLabel = true;
        protected Timer timer;

        public Class1089()
        {
            this.method_0();
            base.SetStyle(ControlStyles.StandardClick, true);
        }

        protected virtual bool DesignModeDetected()
        {
            IDesignerHost service = (IDesignerHost) this.GetService(typeof(IDesignerHost));
            return (service != null);
        }

        protected virtual void Draw(Graphics graphics_0)
        {
            this.DrawButton(graphics_0);
            this.DrawText(graphics_0);
        }

        protected virtual void DrawButton(Graphics graphics_0)
        {
            this.rcRight.X = this.Width - this.imgRight.Width;
            if (this.mousePressed)
            {
                if (base.ClientRectangle.Contains(this.ptMousePosition.X, this.ptMousePosition.Y))
                {
                    this.DrawButtonState(graphics_0, this.iaDefault);
                }
                else
                {
                    this.DrawButtonState(graphics_0, this.iaNormal);
                }
            }
            else if (base.IsDefault)
            {
                this.DrawButtonState(graphics_0, this.iaDefault);
            }
            else
            {
                this.DrawButtonState(graphics_0, this.iaNormal);
            }
        }

        protected virtual void DrawButtonState(Graphics graphics_0, ImageAttributes imageAttributes_0)
        {
            graphics_0.DrawImage(this.imgLeft, this.rcLeft, 0, 0, this.imgLeft.Width, this.imgLeft.Height, GraphicsUnit.Pixel, imageAttributes_0);
            graphics_0.DrawImage(this.imgRight, this.rcRight, 0, 0, this.imgRight.Width, this.imgRight.Height, GraphicsUnit.Pixel, imageAttributes_0);
            TextureBrush brush = new TextureBrush(this.imgFill, new Rectangle(0, 0, this.imgFill.Width, this.imgFill.Height), imageAttributes_0) {
                WrapMode = WrapMode.Tile
            };
            graphics_0.FillRectangle(brush, this.imgLeft.Width, 0, this.Width - (this.imgLeft.Width + this.imgRight.Width), this.imgFill.Height);
            brush.Dispose();
        }

        protected virtual void DrawText(Graphics graphics_0)
        {
            RectangleF layoutRectangle = new RectangleF(0f, 0f, (float) this.Width, (float) (this.Height - ButtonShadowOffset));
            StringFormat format = new StringFormat {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            layoutRectangle.Offset(0f, 1f);
            SolidBrush brush = new SolidBrush(Color.Gray);
            graphics_0.DrawString(this.Text, this.Font, brush, layoutRectangle, format);
            brush.Dispose();
            layoutRectangle.Offset(0f, -1f);
            SolidBrush brush2 = new SolidBrush(Color.Black);
            graphics_0.DrawString(this.Text, this.Font, brush2, layoutRectangle, format);
            brush2.Dispose();
        }

        protected virtual void InitializeGraphics()
        {
            this.rcLeft = new Rectangle(0, 0, this.imgLeft.Width, this.imgLeft.Height);
            this.rcRight = new Rectangle(0, 0, this.imgRight.Width, this.imgRight.Height);
            this.cmDefault = new ColorMatrix();
            this.cmDefault.Matrix33 = 0.5f;
            this.iaDefault = new ImageAttributes();
            this.iaDefault.SetColorMatrix(this.cmDefault, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            this.cmNormal = new ColorMatrix();
            this.cmNormal.Matrix00 = 0.3333333f;
            this.cmNormal.Matrix01 = 0.3333333f;
            this.cmNormal.Matrix02 = 0.3333333f;
            this.cmNormal.Matrix10 = 0.3333333f;
            this.cmNormal.Matrix11 = 0.3333333f;
            this.cmNormal.Matrix12 = 0.3333333f;
            this.cmNormal.Matrix20 = 0.3333333f;
            this.cmNormal.Matrix21 = 0.3333333f;
            this.cmNormal.Matrix22 = 0.3333333f;
            this.cmNormal.Matrix33 = 0.5f;
            this.iaNormal = new ImageAttributes();
            this.iaNormal.SetColorMatrix(this.cmNormal, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
        }

        protected virtual void LoadImages()
        {
            this.imgLeft = Class868.bitmap_2;
            this.imgRight = Class868.bitmap_3;
            this.imgFill = Class868.bitmap_1;
        }

        private void method_0()
        {
        }

        protected override void OnCreateControl()
        {
            this.LoadImages();
            this.InitializeGraphics();
        }

        protected override void OnGotFocus(EventArgs eventArgs_0)
        {
            base.OnGotFocus(eventArgs_0);
            if (this.Boolean_0)
            {
                this.StartPulsing();
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs keyPressEventArgs_0)
        {
            base.OnKeyPress(keyPressEventArgs_0);
            if (this.mousePressed && (keyPressEventArgs_0.KeyChar == '\x001b'))
            {
                this.mousePressed = false;
                this.StartPulsing();
                base.Invalidate();
                base.Update();
            }
        }

        protected override void OnLostFocus(EventArgs eventArgs_0)
        {
            base.OnLostFocus(eventArgs_0);
            if (this.Boolean_0)
            {
                this.StopPulsing();
            }
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            if (mevent.Button == MouseButtons.Left)
            {
                this.mousePressed = true;
                this.ptMousePosition.X = mevent.X;
                this.ptMousePosition.Y = mevent.Y;
                this.StopPulsing();
            }
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);
            if (this.mousePressed && ((mevent.Button & MouseButtons.Left) != MouseButtons.None))
            {
                this.ptMousePosition.X = mevent.X;
                this.ptMousePosition.Y = mevent.Y;
            }
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if (this.mousePressed)
            {
                this.mousePressed = false;
                this.StartPulsing();
                base.Invalidate();
                base.Update();
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics graphics = pevent.Graphics;
            graphics.Clear(base.Parent.BackColor);
            this.Draw(graphics);
        }

        protected override void OnTextChanged(EventArgs eventArgs_0)
        {
            if (this.sizeToLabel)
            {
                Graphics graphics = base.CreateGraphics();
                SizeF ef = graphics.MeasureString(this.Text, this.Font);
                this.Width = (this.imgLeft.Width + ((int) ef.Width)) + this.imgRight.Width;
                graphics.Dispose();
            }
            base.Invalidate();
            base.Update();
            base.OnTextChanged(eventArgs_0);
        }

        protected virtual void StartPulsing()
        {
            if (this.Boolean_0 && !this.DesignModeDetected())
            {
                this.timer = new Timer();
                this.timer.Interval = PulseInterval;
                this.timer.Tick += new EventHandler(this.TimerOnTick);
                this.gamma = PulseGammaMax;
                this.gammaShift = -PulseGammaShift;
                this.timer.Start();
            }
        }

        protected virtual void StopPulsing()
        {
            if (this.timer != null)
            {
                this.iaDefault.SetGamma(1f, ColorAdjustType.Bitmap);
                this.timer.Stop();
            }
        }

        protected virtual void TimerOnTick(object sender, EventArgs e)
        {
            if (((this.gamma - PulseGammaMin) >= PulseGammaReductionThreshold) && ((PulseGammaMax - this.gamma) >= PulseGammaReductionThreshold))
            {
                this.gamma += this.gammaShift;
            }
            else
            {
                this.gamma += this.gammaShift * PulseGammaShiftReduction;
            }
            if ((this.gamma <= PulseGammaMin) || (this.gamma >= PulseGammaMax))
            {
                this.gammaShift = -this.gammaShift;
            }
            this.iaDefault.SetGamma(this.gamma, ColorAdjustType.Bitmap);
            base.Invalidate();
            base.Update();
        }

        [Category("Appearance"), DefaultValue(false), Description("Determines whether the button pulses. Note that only the default button can pulse.")]
        public bool Boolean_0
        {
            get
            {
                return this.pulse;
            }
            set
            {
                this.pulse = value;
            }
        }

        [Description("Determines whether the button should automatically size to fit the label"), Category("Layout"), DefaultValue(true)]
        public bool Boolean_1
        {
            get
            {
                return this.sizeToLabel;
            }
            set
            {
                this.sizeToLabel = value;
                this.OnTextChanged(EventArgs.Empty);
            }
        }

        protected override Size DefaultSize
        {
            get
            {
                return new Size(ButtonDefaultWidth, ButtonHeight);
            }
        }

        [Description("Aqua buttons have a fixed height"), Browsable(true), ReadOnly(true), Category("Layout")]
        public int Height
        {
            get
            {
                return base.Height;
            }
        }

        [Category("Layout"), Browsable(true), Description("See also: SizeToLabel")]
        public int Width
        {
            get
            {
                return base.Width;
            }
            set
            {
                base.Width = value;
            }
        }
    }
}

