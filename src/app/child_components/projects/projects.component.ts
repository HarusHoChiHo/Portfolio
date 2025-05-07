import {Component} from '@angular/core';
import {CardModule} from "primeng/card";
import {Divider} from "primeng/divider";
import {ButtonModule} from "primeng/button";
import {Panel} from "primeng/panel";
import {Ripple} from "primeng/ripple";

@Component({
    selector   : 'app-projects',
    templateUrl: './projects.component.html',
    styleUrl   : './projects.component.css',
    imports: [
        CardModule,
        Divider,
        ButtonModule,
        Panel,
        Ripple
    ]
})
export class ProjectsComponent {
}
