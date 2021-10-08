
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class User : Person {

    public User() {
    }

    

    public int UserID { get; set; }

    public string Password;

    public DateTime CreateTime { get; set; }

    public string Role;

    public int PhoneNumber;

    public string State;

    public int BorrowedNumber;



    public void CreateUserAccount() {
        // TODO implement here
    }

    public void BorrowBook() {
        // TODO implement here
    }

    public void ReturnBook() {
        // TODO implement here
    }

    /// <summary>
    /// @return
    /// </summary>
    public string ViewUserAccount() {
        // TODO implement here
        return "\nUserID:" + this.UserID+
            "\nName:" + this.Name +
            "\nName:" + this.CreateTime;
    }

}