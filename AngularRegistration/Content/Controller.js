
app.controller('myCntrl', function ($scope, myService) {

    $scope.SaveUser = function () {
        $('#divLoading').show();
        var User = {
            Name: $scope.fName,
            Email: $scope.uEmail,
            Password: $scope.uPwd,
          
        };

        var response = myService.AddUser(User);
        response.then(function (data) {
            if (data.data == '1') {
                $('#divLoading').hide();
                clearFields();
                alert('User Created !');
                window.location.href = '/Register/Login';
            }
            else if (data.data == '-1') {
                $('#divLoading').hide();
                alert('user alraedy present !');
            }
            else {
                $('#divLoading').hide();
                clearFields();
                alert('Invalid data entered !');
            }
        });
    }

    function clearFields() {
        $scope.fName = "";
        $scope.Email = "";
        $scope.Password = "";
  
    }

}); 