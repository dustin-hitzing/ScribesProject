namespace ScribesF4.Controllers {
    export class FriendsController {
        public friends;
        public users;
        constructor(private $http: ng.IHttpService) {
            this.friends = [{
                name: 'Tom'
            }];
            $http.get('/api/friends')
                .then((response) => {
                    this.friends = response.data;
                });
        }
        public searchUsers(searchTerm) {
            this.users = [];
            if (searchTerm) {
                this.$http.get(`/api/users/${searchTerm}`)
                    .then((response) => {
                        this.users = response.data;
                    });
            }
        }
    }
}