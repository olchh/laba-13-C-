namespace laba_13
{
    internal class Program
    {
        interface Izdatelstvo
        {
            void book_name_izd();
            void autor_izd();

        }
        interface IBook : Izdatelstvo
        {
            void publish_date_book();
            void kolichestvo_page();

        }
        interface IUser
        {
            void login_user();
            void password_user();
        }
        class Book_realization<T> : IBook
        {
            string book_name;
            string autor;
            T publish_date; //обобщенная переменная, тк нужно 2 обьекта с разными типами данных
            int numbers_of_page;
            public Book_realization(string book_name, string autor, T publish_date, int numbers_of_page)
            {
                this.book_name = book_name;
                this.autor = autor;
                this.publish_date = publish_date;
                this.numbers_of_page = numbers_of_page;

            }
            public void book_name_izd()
            {
                Console.WriteLine($"Книга: {book_name}");
            }
            public void autor_izd()
            {
                Console.WriteLine($"Автор: {autor}");
            }
            public void publish_date_book()
            {
                Console.WriteLine($"Дата публикации: {publish_date}");
            }
            public void kolichestvo_page()
            {
                Console.WriteLine($"Количество страниц: {numbers_of_page}");
            }

        }
        class User<T> : IUser
        {
            T login; //обобщенная переменная, тк в одном случае цифарки, в другом букавки
            string password;

            public User(T login, string password)
            {
                this.login = login;
                this.password = password;
            }

            public void login_user()
            {
                Console.WriteLine($"Логин: {login}");
            }
            public void password_user()
            {
                Console.WriteLine($"Пароль: {password}");
            }
        }
        class Shop : IUser, IBook
        {
            string user_name;
            string book_name;

            public Shop(string user_name, string book_name)
            {
                this.user_name = user_name;
                this.book_name = book_name;
            }

            public void buy()
            {
                Console.WriteLine($"Пользователь: {user_name}, Купил книгу: {book_name}");
            }
            public void login_user()
            {
            }
            public void password_user()
            {
            }
            public void book_name_izd()
            {
            }
            public void autor_izd()
            {
            }
            public void publish_date_book()
            {
            }
            public void kolichestvo_page()
            {
            }
        }
       
        static void Main(string[] args)
        {

            Book_realization<int> book_Realization1 = new Book_realization<int>("Комната ужасов", "Майкл Грей", 26042006, 250);
            Book_realization<string> book_Realization2 = new Book_realization<string>("Комната ужасов", "Майкл Грей", "26 апреля 2006 года", 250);
            book_Realization1.book_name_izd();
            book_Realization1.autor_izd();
            book_Realization1.publish_date_book();
            book_Realization1 .kolichestvo_page();

            User<string> user1 = new User<string>("Pasha", "asdfdhgfdndfi");
            User<int> user2 = new User<int>(228, "fgdgniebdtubo");
            Console.WriteLine(user1);

            Shop shop = new Shop("Egor", "Pomedor");
            shop.buy();

        }
    }
}