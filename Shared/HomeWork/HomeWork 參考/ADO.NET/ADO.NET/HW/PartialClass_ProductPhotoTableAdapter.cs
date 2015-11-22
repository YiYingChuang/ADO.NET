using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.AdventureWorksDataSetTableAdapters
{


    public partial class ProductPhotoTableAdapter : global::System.ComponentModel.Component
    {


        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Fill, false)]
        public virtual int FillByModifiedDate(AdventureWorksDataSet.ProductPhotoDataTable dataTable, System.DateTime Date1, System.DateTime Date2)
        {
            this.Adapter.SelectCommand = this.CommandCollection[1];
            this.Adapter.SelectCommand.Parameters[0].Value = ((System.DateTime)(Date1));
            this.Adapter.SelectCommand.Parameters[1].Value = ((System.DateTime)(Date2));
            if ((this.ClearBeforeFill == true))
            {
                dataTable.Clear();
            }
            int returnValue = this.Adapter.Fill(dataTable);
            return returnValue;
        }

        public SqlCommand SelectCommand
        {
            get
            {
                return CommandCollection[0];
            }
            set
            {
                CommandCollection[0]= value;
            }
        }
    }
}