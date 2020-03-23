package com.RHFA_00118519.x;

public class Main {

    public static void main(String[] args) {

    	//Variables
	 System.out.println("Funciones basicas de la computadora:");
	 String tipo = "Omen HP";
	 String sistemaOP = "Windows";

	 //Objeto declarado
	 Laptop pc1 = new Laptop(tipo, sistemaOP);
	 pc1.encendiendo();

	 Interaccion prueba = new Interaccion();
	 prueba.ejecutar();
	 prueba.menu();

	 pc1.apagando();
    }
}
