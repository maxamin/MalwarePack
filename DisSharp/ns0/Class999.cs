namespace ns0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    internal class Class999 : TextBox
    {
        private const int int_0 = 0x100;
        
		private Delegate0 delegate0_0;

		private Delegate0 delegate0_1;
		
internal event Delegate0 Event_0
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.delegate0_0 = (Delegate0)Delegate.Combine(this.delegate0_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.delegate0_0 = (Delegate0)Delegate.Remove(this.delegate0_0, value);
			}
		}

		internal event Delegate0 Event_1
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.delegate0_1 = (Delegate0)Delegate.Combine(this.delegate0_1, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.delegate0_1 = (Delegate0)Delegate.Remove(this.delegate0_1, value);
			}
		}


        public override bool PreProcessMessage(ref Message msg)
        {
            if (msg.Msg == 0x100)
            {
                if (((int) msg.WParam) == 13)
                {
                    this.delegate0_0(this, Keys.Enter);
                    return true;
                }
                if (((int) msg.WParam) == 0x1b)
                {
                    this.delegate0_1(this, Keys.Escape);
                    return true;
                }
            }
            return base.PreProcessMessage(ref msg);
        }
    }
}

