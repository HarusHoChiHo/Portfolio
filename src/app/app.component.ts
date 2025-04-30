import {Component} from '@angular/core';
import {ProjectsComponent} from "./child_components/projects/projects.component";
import {HomeComponent} from "./child_components/home/home.component";

@Component({
    selector   : 'app-root',
    imports: [
        HomeComponent,
        ProjectsComponent,
    ],
    templateUrl: './app.component.html',
    styleUrl   : './app.component.css'
})
export class AppComponent {
}
