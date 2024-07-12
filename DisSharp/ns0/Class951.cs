namespace ns0
{
    using System;
    using System.Data;
    using System.Reflection;
    using System.Windows.Forms;

    internal class Class951
    {
        private DataGrid dataGrid_0;
        private DataTable dataTable_0 = new DataTable();

        internal Class951(DataGrid A_1)
        {
            this.dataGrid_0 = A_1;
            A_1.CaptionVisible = false;
            A_1.ReadOnly = false;
        }

        internal void method_0(string A_1, System.Type A_2)
        {
            this.dataTable_0.Columns.Add(A_1, A_2);
        }

        internal void method_1(params object[] A_1)
        {
            this.dataTable_0.Rows.Add(A_1);
        }

        internal void method_2(Form A_1)
        {
            this.dataGrid_0.DataSource = this.dataTable_0;
            CurrencyManager manager = (CurrencyManager) A_1.BindingContext[this.dataGrid_0.DataSource, this.dataGrid_0.DataMember];
            DataView list = (DataView) manager.List;
            list.AllowNew = false;
            list.AllowDelete = false;
        }

        internal object this[int A_1, int A_2]
        {
            get
            {
                return this.dataTable_0.Rows[A_2][A_1];
            }
        }
    }
}

