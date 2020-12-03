namespace AulaPOOCelular.cel
{
    public class Celular
    {
        //atributos
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

            return "Você está realizando uma chamada";

        }

        public string EnviarMensagem(){
            return "Você está enviando uma mensagem";
        }

        
        
    }
}