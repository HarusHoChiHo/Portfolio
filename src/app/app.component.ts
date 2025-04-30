import {Component} from '@angular/core';
import {RouterLink, RouterLinkActive, RouterOutlet} from '@angular/router';
import {Button} from "primeng/button";
import {AppModule} from "./app.module";
import {ProjectsComponent} from "./child_components/projects/projects.component";

@Component({
    selector   : 'app-root',
    imports: [
        RouterOutlet,
        RouterLink,
        RouterLinkActive
    ],
    templateUrl: './app.component.html',
    styleUrl   : './app.component.css'
})
export class AppComponent {
}
