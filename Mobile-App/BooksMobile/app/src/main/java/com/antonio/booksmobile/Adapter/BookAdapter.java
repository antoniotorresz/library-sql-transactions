package com.antonio.booksmobile.Adapter;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.recyclerview.widget.RecyclerView;

import com.antonio.booksmobile.Model.Book;
import com.antonio.booksmobile.R;
import com.bumptech.glide.Glide;

import java.util.List;

public class BookAdapter extends RecyclerView.Adapter<BookAdapter.BookVH> {

    private static final String TAG = "MovieAdapter";
    private List<Book> bookList;

    public BookAdapter(List<Book> books) {
        this.bookList = books;
    }

    @NonNull
    @Override
    public BookVH onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.book_row, parent, false);
        return new BookVH(view);
    }

    @Override
    public void onBindViewHolder(@NonNull BookVH holder, int position) {

        Book book = bookList.get(position);
        holder.titleTextView.setText(book.getTitulo());
        holder.yearTextView.setText(book.getFechaPublicacion());
        holder.authors.setText(book.getAutores());
        holder.editorial.setText(book.getEditorial());
        holder.isbn.setText(book.getIsbn());


        Glide.with(holder.imgvLibro.getContext())
                .load(book.getImageUrl())
                .centerCrop()
                .into(holder.imgvLibro);

        boolean isExpanded = bookList.get(position).isExpanded();
        holder.expandableLayout.setVisibility(isExpanded ? View.VISIBLE : View.GONE);
    }

    @Override
    public int getItemCount() {
        return bookList.size();
    }

    class BookVH extends RecyclerView.ViewHolder {

        private static final String TAG = "BookVH";

        ConstraintLayout expandableLayout;
        ImageView imgvLibro;
        TextView titleTextView, yearTextView, authors, editorial, isbn;

        public BookVH(@NonNull final View itemView) {
            super(itemView);

            imgvLibro = itemView.findViewById(R.id.imgvLibro);
            titleTextView = itemView.findViewById(R.id.titleTextView);
            yearTextView = itemView.findViewById(R.id.yearTextView);
            authors = itemView.findViewById(R.id.autoresTextView);
            editorial = itemView.findViewById(R.id.editorialTextView);
            isbn = itemView.findViewById(R.id.isbnTextView);
            expandableLayout = itemView.findViewById(R.id.expandableLayout);


            titleTextView.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {

                    Book book = bookList.get(getAdapterPosition());
                    book.setExpanded(!book.isExpanded());
                    notifyItemChanged(getAdapterPosition());

                }
            });
        }
    }
}
