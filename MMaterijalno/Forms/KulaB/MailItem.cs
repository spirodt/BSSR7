namespace MMaterijalno.Forms.KulaB
{
    internal class MailItem
    {
        public MailItem()
        {
        }

        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public string Email { get; set; }
        public string Telefoni { get; set; }

        public override string ToString()
        {
            return $"{Sifra} {Naziv} {Telefoni} :{Email}";
        }
    }
}