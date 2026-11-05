namespace ProyectoG4Backend.DTOs;

/**DTO significa Data Transfer Object
*Es una clase que escribe solo los datos que el FE debe enviar
**/
public class RegisterDTO
{
   public string FullName { get; set; } = string.Empty;
   public string Email { get; set; } = string.Empty;
   public string Password { get; set; } = string.Empty;

}