import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-autenticacion',
  templateUrl: './autenticacion.component.html',
  styleUrls: ['./autenticacion.component.scss']
})
export class AutenticacionComponent implements OnInit {

  username: string;
  password: string;
  mostrarProgressBar: boolean = false;

  constructor(private router: Router) { }

  ngOnInit() {
  }

  login(): void {
    this.mostrarProgressBar = true;

    setTimeout(() => {

      if (this.username == '2013000664' && this.password == '331904') {
        this.router.navigate(["../inicio"]);
      } else {
        alert("Datos invalidos");
      }

    }, 3500)
  }

}
