using System.Collections.Generic;

namespace E_Trade.Model.Entity
{
    public class MailListGroup
    {
        public MailListGroup()
        {
            MailLists = new HashSet<MailList>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<MailList> MailLists { get; set; }
    }
}
