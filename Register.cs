@model LoginandRegister.Models.User
@{
    ViewBag.Title = "Register";
    Layout = "~/Views/Shared/_LayoutPage1.cshtml";
}
<div class="row justify-content-md-center">
    <div class="col-md-5">
        @using (Html.BeginForm("Register", "Home", FormMethod.Post))
        {
            //@Html.ValidationSummary()
            @Html.AntiForgeryToken()

            <div class="card">
                <div class="card-header">
                    <div class="card-title">Register</div>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        @Html.LabelFor(m => m.FirstName)
                        @Html.TextBoxFor(m => m.FirstName, "", new { @class = "form-control", @placeholder = "First Name" })
                        @Html.ValidationMessageFor(m => m.FirstName, "", new { @class = "badge badge-danger" })
                    </div>
                    <div class="form-group">
                        @Html.LabelFor(m => m.LastName)
                        @Html.TextBoxFor(m => m.LastName, "", new { @class = "form-control", @placeholder = "Last Name" })
                        @Html.ValidationMessageFor(m => m.LastName, "", new { @class = "badge badge-danger" })

                    </div>
                    <div class="form-group">
                        @Html.LabelFor(m => m.Email)
                        @Html.TextBoxFor(m => m.Email, "", new { @class = "form-control", @placeholder = "Email" })
                        @Html.ValidationMessageFor(m => m.Email, "", new { @class = "badge badge-danger" })
                        @if (ViewBag.error != null)
                        {
                            <span class="badge badge-danger">@ViewBag.error</span>
                        }
                    </div>
                    <div class="form-group">
                        @Html.LabelFor(m => m.Password)
                        @Html.PasswordFor(m => m.Password, new { @class = "form-control", @placeholder = "Password" })
                        @Html.ValidationMessageFor(m => m.Password, "", new { @class = "badge badge-danger" })
                    </div>
                    <div class="form-group">
                        @Html.LabelFor(m => m.ConfirmPassword)
                        @Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control", @placeholder = "Confim Password" })
                        @Html.ValidationMessageFor(m => m.ConfirmPassword, "", new { @class = "badge badge-danger" })
                    </div>
                    <div class="form-group">
                        <input type="submit" name="submit" class="btn btn-danger" value="Register" />
                    </div>
                </div>
            </div>

        }
    </div>
</div>

