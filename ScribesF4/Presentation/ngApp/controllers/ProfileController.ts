namespace ScribesF4.Controllers {
    export class ProfileController {
        public error = '';
        constructor(private $http: ng.IHttpService) { }
        public makeStory(prompt) {
            if (prompt != '') {
                this.$http.post('/api/create', { prompt: prompt })
                    .then((response) => {

                    });
            }else
            return this.error = "Your prompt must contain at least a single character";
        }
    }
}