import {Component} from '@angular/core';
import {CardModule} from "primeng/card";
import {Divider} from "primeng/divider";
import {ButtonModule} from "primeng/button";

@Component({
    selector   : 'app-projects',
    templateUrl: './projects.component.html',
    styleUrl   : './projects.component.css',
    imports    : [
        CardModule,
        Divider,
        ButtonModule
    ]
})
export class ProjectsComponent {
}
