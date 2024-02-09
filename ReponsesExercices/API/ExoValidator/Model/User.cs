using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace ExoValidator.Model
{
    [Table("contact")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("DateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Password")]
        [RegularExpression(@"^(?=.*[a-z].*[a-z])(?=.*[A-Z].*[A-Z])(?=.*\d.*\d)[A-Za-z\d]{6,}$",
                           ErrorMessage = "Le mot de passe doit contenir au moins 6 caractères avec au moins 2 majuscules, 2 minuscules et 2 chiffres.")]
        public string Password { get; set; }
    }
    public class PasswordValidation2 : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var password = value as string;

            if (string.IsNullOrEmpty(password))
            {
                ErrorMessage = " Password ne doit pas etre vide";
            }

            var numberCount = new Regex(@"[0-9]{2,}");
            var uppercaseCount = new Regex(@"[A-Z]{2,}");
            var lowercaseCount = new Regex(@"[a-z]{2,}");           
            var passwordLenght = new Regex(@".{8,15}");
            var symbol = new Regex(@"[.+*?!:;,^@/$(){}|]{3}");

            if (!numberCount.IsMatch(password)) 
            {
                ErrorMessage = "Il manque des chiffres";
            }
            if (uppercaseCount.IsMatch(password))
            {
                ErrorMessage = "Il manque des majuscules";
            }
            if (lowercaseCount.IsMatch(password))
            {
                ErrorMessage = "Il manque des majuscules";
            }
            if (passwordLenght.IsMatch(password))
            {
                ErrorMessage = "Il manque des carectères (8/15)";
            }
            if (symbol.IsMatch(password))
            {
                ErrorMessage = "Il manque des symboles";
            }        
            if (ErrorMessage == string.Empty)
            {
                return true;
            }
            return false;
        }

        //public class PasswordValidation : ValidationAttribute
        //{
        //    public override bool IsValid(object value)
        //    {
        //        var password = value as string;

        //        if (string.IsNullOrEmpty(password))
        //        {
        //            ErrorMessage = " Password ne doit pas etre vide";
        //            return false;
        //        }

        //        if (password.Length < 6)
        //            return false;

        //        int uppercaseCount = 0;
        //        int lowercaseCount = 0;
        //        int numberCount = 0;

        //        foreach (char c in password)
        //        {
        //            if (char.IsUpper(c))
        //                uppercaseCount++;
        //            else if (char.IsLower(c))
        //                lowercaseCount++;
        //            else if (char.IsDigit(c))
        //                numberCount++;
        //        }
        //        return uppercaseCount >= 2 && lowercaseCount >= 2 && numberCount >= 2;
        //    }
        //}
    }
}
