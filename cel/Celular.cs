namespace AulaPOOCelular.cel
{
    public class Celular
    {
        public string modelo;
        public string cor;
        public string tamanho;
        public bool ligado = false;
        public string ligacao;
        public string mensagem;

        public bool LigarEDesligar(bool status){

            if (this.ligado == true)
            {
                return this.ligado == false;
            }
                return this.ligado == false;

        }

        public string FazerLigacao(){

            if (ligacao == "s" && this.ligado)
            {
                return ("Realizando chamada...");
            }else{
                return ("Suspendendo chamada");
            }

        }

        
        
    }
}