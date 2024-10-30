using CandidateManagement_BusinessObject;
using CandidateManagement_Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandidateManagement_NguyenVanVinh.Pages
{
    public class LoginModel : PageModel
    {
        private IHRAccountRepo accountRepo;

        public LoginModel(IHRAccountRepo accountRepo)
        {
            this.accountRepo = accountRepo;
        }
        public void OnPost()
        {
            String email = Request.Form["txtEmail"];

            String password = Request.Form["txtPassword"];

            Hraccount hraccount = accountRepo.GetHraccountByEmail(email);
            if (hraccount != null && hraccount.Password.Equals(password))
            {
                //HttpContext.Session.SetString("RoleID", accountEuro.RoleId.ToString());
                Response.Redirect("/CandidateProfilePage");
            }
            else
            {
                Response.Redirect("/Error");
            }


        }
    }
}
