internal class Program
{
    private static void Main(string[] args)
    {
        int[,] velha = new int[3, 3];
        int l, c;
        for(int i = 0; i < 9; i++)
        {
            exibir(velha);

            Console.WriteLine("digite a linha que quer colocar: ");
            l = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a coluna que quer colocar: ");
            c = int.Parse(Console.ReadLine());

            if (velha[l, c] == 0)
            {
                if(i%2 == 0)
                {
                    velha[l, c] = 1;
                }
                else
                {
                    velha[l, c] = 2;
                }

                if (VenceuHorizontal(velha) || VenceuVertical(velha) || VenceuDiagonalPrincial(velha) || VenceuDiagonalSecundaria(velha))
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("o primeiro jogador ganhou");
                    }
                    else
                    {
                        Console.WriteLine("o segundo jogador ganhou");
                    }
                    exibir(velha);
                    break;
                }
                
            }
            else
            {
                Console.WriteLine("ja tem coisa ai mano");
                i--; 
            }

        }

        void exibir(int[,] velha)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(velha[j, k] + " ");
                }
                Console.WriteLine();
            }
        }

        bool VenceuHorizontal(int[,] velha)
        {
            int valida, igual=0;

            for(int l = 0; l < 3; l++)
            {
                valida = 0;
                for(int c = 0; c < 3; c++)
                {
                    if (velha[l, c] != 0)
                    {
                        if (valida == 0)
                        {
                            igual = velha[l, c];
                            valida++;
                        }
                        else
                        {
                            if (velha[l, c] == igual)
                            {
                                valida++;
                                igual = velha[l, c];
                            }
                        }
                    }
                }

                if(valida == 3)
                {
                    return true;
                }
            }

            return false;
        }


        bool VenceuVertical(int[,] velha)
        {
            int valida, igual = 0;

            for (int c = 0; c < 3; c++)
            {
                valida = 0;
                for (int l = 0; l < 3; l++)
                {
                    if (velha[l, c] != 0)
                    {
                        if (valida == 0)
                        {
                            igual = velha[l, c];
                            valida++;
                        }
                        else
                        {
                            if (velha[l, c] == igual)
                            {
                                valida++;
                                igual = velha[l, c];
                                Console.WriteLine(igual);
                            }
                        }
                    }
                }

                if (valida == 3)
                {
                    return true;
                }
            }

            return false;
        }



        bool VenceuDiagonalPrincial(int[,] velha)
        {
            int valida=0, igual = 0;

            for (int l = 0; l < 3; l++)
            {

                if (velha[l, l] != 0)
                {
                    if (l == 0)
                    {
                        igual = velha[l, l];
                        valida++;
                    }
                    else
                    {
                        if (velha[l, l] == igual)
                        {
                            valida++;
                            igual = velha[l, l];
                        }
                    }
                }

                if (valida == 3)
                {
                    return true;
                }
            }

            return false;
        }


        bool VenceuDiagonalSecundaria(int[,] velha)
        {
            int valida = 0, igual = 0;

            for (int l = 0; l < 3; l++)
            {

                if (velha[l, 2-l] != 0)
                {
                    if (l == 0)
                    {
                        igual = velha[l, 2-l];
                        valida++;
                    }
                    else
                    {
                        if (velha[l, 2-l] == igual)
                        {
                            valida++;
                            igual = velha[l, 2-l];
                            Console.WriteLine(igual);
                        }
                    }
                }

                if (valida == 3)
                {
                    return true;
                }
            }

            return false;
        }
    }
}