import {Component} from '@angular/core';
import {CardModule} from "primeng/card";
import {Divider} from "primeng/divider";
import {ButtonModule} from "primeng/button";
import {Panel} from "primeng/panel";
import {Fieldset} from "primeng/fieldset";

@Component({
    selector   : 'app-projects',
    templateUrl: './projects.component.html',
    styleUrl   : './projects.component.css',
    imports: [
        CardModule,
        Divider,
        ButtonModule,
        Panel
    ]
})
export class ProjectsComponent {
}
