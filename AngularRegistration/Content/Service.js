app.Service('myService', function ($http) {

    this.AddUser = function (User) {
        var response = $http({
            method: 'Post',
            url: '/Users/AddUser',
            data: JSON.stringify(User),
            dataType: 'json'
        });
        return response;
    }
}); 
