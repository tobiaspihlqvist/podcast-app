using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast.Business_logic_layer
{
    public class Category : IListable
    {
        public string Name { get; set; }
        public  CustomList<Category> CategoryList { get; set; }

        protected virtual List<string> PrepareListViewItem()
        {
            return new List<string> {Name};
        } 

        public virtual ListViewItem ToListViewItem()
        {
            return new ListViewItem(PrepareListViewItem().ToArray());
        }


    }
}

