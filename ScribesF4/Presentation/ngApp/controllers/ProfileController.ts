namespace ScribesF4.Controllers {
    export class ProfileController {
        public error = '';
        public modalInstance;
        constructor(private $http: ng.IHttpService, private $uibModal) { }
        
        public openModal(): void {
            this.modalInstance = this.$uibModal.open({
                templateUrl: '/Presentation/ngApp/views/modal.html',
                controller: ScribesF4.Controllers.ModalController,
                controllerAs: 'controller'
            })
        }
    }
}
