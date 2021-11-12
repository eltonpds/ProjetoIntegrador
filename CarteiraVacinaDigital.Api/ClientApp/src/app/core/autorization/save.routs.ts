import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";
import { FuncionarioService } from "src/app/module/funcionario/funcionario.service";
import { Employee } from "../model/employee";

@Injectable({
    providedIn: 'root'
})
export class SaveRouts implements CanActivate {
    
    employee = new Employee();

    constructor(private _router: Router, private _employeeService: FuncionarioService) {
        
    }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean  {        
        if (this._employeeService.employeeAuthenticated()) {
            return true;
        }

        this._router.navigate(['/login'], { queryParams: { returnUrl: state.url } });
        return false;
    }

}
