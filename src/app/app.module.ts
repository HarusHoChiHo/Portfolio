import {NgModule} from '@angular/core';
import {AppComponent} from './app.component';
import {AboutComponent} from './child_components/about/about.component';
import {ProjectsComponent} from './child_components/projects/projects.component';
import {ContactComponent} from './child_components/contact/contact.component';
import {BrowserModule} from '@angular/platform-browser';

@NgModule({
  declarations: [AboutComponent, ProjectsComponent, ContactComponent],
  imports: [BrowserModule, AppComponent],
})
export class AppModule {}
