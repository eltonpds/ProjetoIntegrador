import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";

@Injectable({
    providedIn: 'root'
})
export class SaveRouts implements CanActivate {
    
    constructor(private _router: Router) {
        
    }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean  {
        var authenticated = sessionStorage.getItem("funcionario-autenticado");

        if (authenticated == "1") {
            return true;
        }

        this._router.navigate(['/login'], { queryParams: { returnUrl: state.url } });
        return false;
    }

}
