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
        string Name { get; set; }
        CustomList<String> CategoryList { get; set; }

        public Category(){
            CustomList<String> CategoryList = new CustomList<String>();
            CategoryList.Add("Humour");
            CategoryList.Add("Horror");
            CategoryList.Add("Business");
            CategoryList.Add("Lifestyle");
        }

        public virtual ListViewItem ToListViewItem()
        {
            return new ListViewItem(CategoryList);
        }
    }
}
