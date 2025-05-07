import {ApplicationConfig, provideZoneChangeDetection} from '@angular/core';
import {provideRouter} from '@angular/router';

import {routes} from './app.routes';
import {providePrimeNG} from 'primeng/config';
import {provideAnimationsAsync} from '@angular/platform-browser/animations/async';
import Aura from '@primeng/themes/aura';
import {definePreset} from "@primeng/themes";

const MyPreset = definePreset(Aura, {
    semantic: {
        primary    : {
            color       : '#000000',       // Black background
            inverseColor: '#ffffff' // White text
        },
        colorScheme: {
            light: {
                primary: {
                    color       : '{surface.950}',     // Black
                    inverseColor: '{surface.0}' // White
                }
            },
            dark : {
                primary: {
                    color       : '{surface.0}',       // White
                    inverseColor: '{surface.950}' // Black
                }
            }
        }
    }
});

export const appConfig: ApplicationConfig = {
    providers: [
        provideZoneChangeDetection({eventCoalescing: true}),
        provideRouter(routes),
        provideAnimationsAsync(),
        providePrimeNG({
            theme: {
                preset: MyPreset
            }
        })
    ]
};
