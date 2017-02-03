import { Component } from '@angular/core';

import { JourneyResearch } from '../shared/model/JourneyResearch';

@Component({
    moduleId: module.id,
    selector: 'search-form',
    templateUrl: './search-form.component.html'
})
export class SearchFormComponent {
    model = new JourneyResearch(new Date(), "", "", 1, 1);
    submitted = false;

    onSubmit() { this.submitted = true; }

    // TODO: Remove this when we're done
    get diagnostic() { return JSON.stringify(this.model); }
}
