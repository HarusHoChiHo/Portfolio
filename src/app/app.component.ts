import {Component} from '@angular/core';
import {RouterLink, RouterLinkActive, RouterOutlet} from '@angular/router';
import {Button} from "primeng/button";
import {AppModule} from "./app.module";
import {ProjectsComponent} from "./child_components/projects/projects.component";
import {HomeComponent} from "./child_components/home/home.component";
import {AboutComponent} from "./child_components/about/about.component";
import {ContactComponent} from "./child_components/contact/contact.component";

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
