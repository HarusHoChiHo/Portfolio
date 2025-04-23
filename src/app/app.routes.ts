import {Routes} from '@angular/router';
import {AboutComponent} from './child_components/about/about.component';
import {ProjectsComponent} from './child_components/projects/projects.component';
import {ContactComponent} from './child_components/contact/contact.component';
import {HomeComponent} from './child_components/home/home.component';

export const routes: Routes = [
  {path:'', component:HomeComponent},
  {path: "about", component: AboutComponent},
  {path: "projects", component: ProjectsComponent},
  {path: "contact", component: ContactComponent}
];
