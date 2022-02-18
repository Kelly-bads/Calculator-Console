namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {

            Console.Clear();
            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplição");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Porcentagem");

            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    Percentage();
                    break;
                default:
                    Console.WriteLine("Opcão invalida, tente novamente!");
                    Menu();
                    break;
            }
        }
        static void SubMenu()
        {

            Console.WriteLine("Deseja realizar outra operação?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");

            Console.WriteLine("Selecione uma opção: ");
            short opc = short.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Menu();
                    break;
                case 2:
                    Console.WriteLine("Okay, até a proxima!");
                    break;
            }
        }
        static void Addition()
        {

            Console.Clear();
            Console.WriteLine("Informe o primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Total: {v1 + v2}");

            SubMenu();

        }
        static void Subtraction()
        {

            Console.Clear();
            Console.WriteLine("Informe o primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Total: {v1 - v2}");

            SubMenu();

        }
        static void Multiplication()
        {

            Console.Clear();
            Console.WriteLine("Informe o primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Total: {v1 * v2}");

            SubMenu();

        }
        static void Division()
        {
            Console.Clear();
            Console.WriteLine("Informe o primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Total: {v1 / v2}");

            SubMenu();

        }
        static void Percentage()
        {

            Console.Clear();
            Console.WriteLine("Informe o primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a porcentagem: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Total: {(v2 / 100) * v1}");

            SubMenu();
        }
    }
}