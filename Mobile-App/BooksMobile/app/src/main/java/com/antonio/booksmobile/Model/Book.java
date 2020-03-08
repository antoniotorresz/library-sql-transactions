package com.antonio.booksmobile.Model;

import androidx.annotation.Keep;

@Keep
public class Book {
    private int idLibro;
    private String titulo;
    private String editorial;
    private String fechaPublicacion;
    private String pais;
    private String isbn;
    private String imageUrl;
    private String autores;
    private boolean expanded;

    public Book() {
    }

    public Book(int idLibro, String titulo, String editorial, String fechaPublicacion, String pais, String isbn, String imageUrl, String autores, boolean expanded) {
        this.idLibro = idLibro;
        this.titulo = titulo;
        this.editorial = editorial;
        this.fechaPublicacion = fechaPublicacion;
        this.pais = pais;
        this.isbn = isbn;
        this.imageUrl = imageUrl;
        this.autores = autores;
        this.expanded = false;
    }

    public int getIdLibro() {
        return idLibro;
    }

    public void setIdLibro(int idLibro) {
        this.idLibro = idLibro;
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public String getEditorial() {
        return editorial;
    }

    public void setEditorial(String editorial) {
        this.editorial = editorial;
    }

    public String getFechaPublicacion() {
        return fechaPublicacion;
    }

    public void setFechaPublicacion(String fechaPublicacion) {
        this.fechaPublicacion = fechaPublicacion;
    }

    public String getPais() {
        return pais;
    }

    public void setPais(String pais) {
        this.pais = pais;
    }

    public String getIsbn() {
        return isbn;
    }

    public void setIsbn(String isbn) {
        this.isbn = isbn;
    }

    public String getImageUrl() {
        return imageUrl;
    }

    public void setImageUrl(String imageUrl) {
        this.imageUrl = imageUrl;
    }

    public String getAutores() {
        return autores;
    }

    public void setAutores(String autores) {
        this.autores = autores;
    }

    public boolean isExpanded() {
        return expanded;
    }

    public void setExpanded(boolean expanded) {
        this.expanded = expanded;
    }

    @Override
    public String toString() {
        return "Book{" +
                "idLibro=" + idLibro +
                ", titulo='" + titulo + '\'' +
                ", editorial='" + editorial + '\'' +
                ", fechaPublicacion='" + fechaPublicacion + '\'' +
                ", pais='" + pais + '\'' +
                ", isbn='" + isbn + '\'' +
                ", imageUrl='" + imageUrl + '\'' +
                ", autores='" + autores + '\'' +
                ", expanded=" + expanded +
                '}';
    }
}
