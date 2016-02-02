namespace ScribesF4.Controllers {
    export class ModalController {
        public error = '';
        public modalInstance;

        constructor(private $http: ng.IHttpService, private $uibModalInstance) { }

        public makeStory(prompt) {
            if (prompt != '') {
                this.$http.post('/api/create', { prompt: prompt })
                    .then((response) => {
                        this.$uibModalInstance.close();
                    });
            } else {
                return this.error = "Your prompt must contain at least a single character";
            }
        }
    }
}
    
