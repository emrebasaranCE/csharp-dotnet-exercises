namespace Kart_namespace
{
    class Kart
    {
        private string _name;
        private string _content;
        private size_of_job _size;
        private int _assigned_to;

        public string Name { get => _name; set => _name = value.Trim(); }
        public string Content { get => _content; set => _content = value.Trim(); }
        internal size_of_job Size { get => _size; set => _size = value; }
        public int Assigned_to { get => _assigned_to; set => _assigned_to = value; }

        public Kart() { }

        public Kart(string name, string content, int assigment, size_of_job size)
        {
            this.Name = name;
            this.Content = content;
            this.Size = size;
            this.Assigned_to = assigment;
        }
    }
    enum size_of_job
    {
        XS,
        S,
        M,
        L,
        XL
    }
}