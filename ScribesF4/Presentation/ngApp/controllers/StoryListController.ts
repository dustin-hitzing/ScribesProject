namespace ScribesF4.Controllers {
    export class StoryListController {
        public story;
        public active;
        constructor(private $http: ng.IHttpService) {
            $http.get('/api/list')
                .then((response) => {
                    this.story = response.data;
                });
        }
        
    }
}