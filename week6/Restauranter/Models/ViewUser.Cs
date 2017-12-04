using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Restauranter.Models.ViewUser
{
    public class ViewUser : BaseEntity
    {
        public List<User> NewUsers {get;set;}

    }
}