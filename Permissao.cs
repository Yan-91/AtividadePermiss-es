using System;

namespace Aula13
{
    public class Permissao
    {
        public bool Permitir {get;set;}
        public void Autorizar(){
            
            Console.WriteLine("Deseja permitir acesso? Digite true ou false");
            try{
                            Permitir = Boolean.Parse( Console.ReadLine());

            }catch (Exception)
            {
                System.Console.WriteLine("Erro na aplicação : dados inválidos");
            }
        }
    }
}