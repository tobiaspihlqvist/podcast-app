using System.Windows.Forms;

namespace Podcast.Business_logic_layer
{
    public interface IListable
    {
        ListViewItem ToListViewItem();

    }
}
