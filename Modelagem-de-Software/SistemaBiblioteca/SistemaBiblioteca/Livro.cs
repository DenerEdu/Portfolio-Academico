namespace SistemaBiblioteca
{
    public class Livro
    {
        private string isbn;
        private string titulo;
        private int ano;
        private StatusLivro status;

        public Livro(string isbn, string titulo, int ano)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.ano = ano;
            this.status = StatusLivro.DISPONIVEL;
        }

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public StatusLivro Status
        {
            get { return status; }
        }

        public bool EstaDisponivel()
        {
            return status == StatusLivro.DISPONIVEL;
        }

        public void AlterarStatus(StatusLivro s)
        {
            status = s;
        }

        public override string ToString()
        {
            return titulo + " (" + ano + ") - ISBN: " + isbn + " - " + status;
        }
    }
}
