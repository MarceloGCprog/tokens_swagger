namespace jwt_token.Models
{
    public class User
    {
        public string? 	UserId { get; set; } // ? permite o acesso ao "operando" quando este nao for nulo. 
        public string? Password { get; set; } // caso contrario, retorna null.

    }
    
}