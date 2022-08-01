

using System.Data.Entity;
using TestApplicationApi.Data;



namespace TestApplicationApi.Model
{


    public class DbHelper
    {
        private EF_DataContext _context;
        public DbHelper(EF_DataContext context)
        {
            _context = context;
        }
        public List<ContactModel> GetContacts()
        {
            List<ContactModel> response = new List<ContactModel>();
            var dataList = _context.Contacts.ToList();
            dataList.ForEach(row => response.Add(new ContactModel()
            {
                contact_firstname = row.contact_firstname,
                contact_lastname = row.contact_lastname,
                email = row.email

            }));
            return response;
        }
        public ContactModel GetContactByEmail(string email)
        {
            ContactModel response = new ContactModel();
            var row = _context.Contacts.Where(d => d.email.Equals(email)).FirstOrDefault();
            return new ContactModel()
            {
                email = row.email,
                contact_firstname = row.contact_firstname,
                contact_lastname = row.contact_lastname

            };
        }
        public void SaveContact(ContactModel contactModel)
        {
            Contact dbTable = new Contact();
            if (contactModel.email != string.Empty)
            {
                //PUT
                dbTable = _context.Contacts.Where(d => d.email.Equals(contactModel.email)).FirstOrDefault();
                if (dbTable != null)
                {
                    dbTable.contact_firstname = contactModel.contact_firstname;
                    dbTable.contact_lastname = contactModel.contact_lastname;
                }
            }
            else
            {
                //POST
                dbTable.email = contactModel.email;
                dbTable.contact_firstname = contactModel.contact_firstname;
                dbTable.contact_lastname = contactModel.contact_lastname;

            }
            _context.SaveChanges();
        }
        public void DeleteContact(string email)
        {
            var contact = _context.Contacts.Where(d => d.email.Equals(email)).FirstOrDefault();
            if (contact != null)
            {
                _context.Contacts.Remove(contact);
                _context.SaveChanges();
            }

        }
        public void SaveAccount(AcountModel acount)
        {
            Acountcs db = new Acountcs();
            if (acount.accountName != string.Empty)
            {
                db = _context.Acountcss.Where(d => d.accountName.Equals(acount.accountName)).FirstOrDefault();
                if (db != null)
                {
                    db.accountName = acount.accountName;
                }
            }
            else
            {
                db.accountName = acount.accountName;
                db.Contact = _context.Contacts.Where(f => f.email.Equals(acount.email_indf)).FirstOrDefault();
                _context.Acountcss.Add(db);
            }
            _context.SaveChanges();
        }
        public void SaveIncident(IncidentModel incident)
        {
            Incident db = new Incident();

            if(incident.incident_name != string.Empty)
            {
                db = _context.Incidents.Where(d => d.incident_name.Equals(incident.incident_name)).FirstOrDefault();

                if(db != null)
                {
                    db.incident_name = incident.incident_name;
                    db.incident_description=incident.incident_description;
                }

            }
            else
            {
                db.incident_name = incident.incident_name;
                db.incident_description = incident.incident_description;
                db.Acount= _context.Acountcss.Where(f => f.accountName.Equals(incident.account_idenf)).FirstOrDefault();
                _context.Incidents.Add(db);
            }
            _context.SaveChanges();
        }
    }
}
   
    
   

