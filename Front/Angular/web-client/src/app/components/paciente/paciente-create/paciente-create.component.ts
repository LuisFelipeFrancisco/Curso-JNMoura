import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-paciente-create',
  templateUrl: './paciente-create.component.html',
  styleUrls: ['./paciente-create.component.css']
})
export class PacienteCreateComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  back(): void {
    this.router.navigate(['paciente/paciente-index']);
  }
}
