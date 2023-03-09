internal class Program
{
    private static void Main(string[] args)
    {
        int[,] velha = new int[3, 3];
        int l, c;
        for(int i = 0; i < 9; i++)
        {
            exibir();

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

                if (VenceuHorizontal() || VenceuVertical() || VenceuDiagonalPrincial() || VenceuDiagonalSecundaria())
                {
                    Console.WriteLine("ganhou");
                    exibir();
                    break;
                }
                
            }
            else
            {
                Console.WriteLine("ja tem coisa ai mano");
                i--; 
            }

        }

        void exibir()
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

        bool VenceuHorizontal()
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
                            //Console.WriteLine(igual);
                            valida++;
                        }
                        else
                        {
                            if (velha[l, c] == igual)
                            {
                                valida++;
                                igual = velha[l, c];
                                //Console.WriteLine(igual);
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


        bool VenceuVertical()
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
                            //Console.WriteLine(igual);
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



        bool VenceuDiagonalPrincial()
        {
            int valida=0, igual = 0;

            for (int l = 0; l < 3; l++)
            {

                if (velha[l, l] != 0)
                {
                    if (l == 0)
                    {
                        igual = velha[l, l];
                        //Console.WriteLine(igual);
                        valida++;
                    }
                    else
                    {
                        if (velha[l, l] == igual)
                        {
                            valida++;
                            igual = velha[l, l];
                            //Console.WriteLine(igual);
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


        bool VenceuDiagonalSecundaria()
        {
            int valida = 0, igual = 0;

            for (int l = 0; l < 3; l++)
            {

                if (velha[l, 2-l] != 0)
                {
                    if (l == 0)
                    {
                        igual = velha[l, 2-l];
                        //Console.WriteLine(igual);
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