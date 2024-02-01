import {useState } from 'react'
let book = [
    {title:'Harry potter',lang:'english',publisher:'dc books',author:'Jk rowling'},
    {title:'davinci code',lang:'english',publisher:'lok',author:'Dan brown'},
    {title:'how to win',lang:'english',publisher:'jk books',author:'Dale carnegir'},
    {title:'Harry potter lost ark',lang:'english',publisher:'dc books',author:'Jk rowling'}
]

export default function BookFn() {
     
    
    const [books,setBook]= useState(book);
    const [title,setTitle]= useState('')
    const [lang,setLang]= useState('')
    const [publisher,setPubli]= useState('')
    const [author,setAuthor]= useState('')
    const AddBook = (e) => {
        setBook([
            ...books,
            {
                title: title,
                lang: lang,
                publisher: publisher,
                author: author
            }
        ]);
        e.preventDefault();
    };

    // const EditBook = (e) => {
    //     setBook([
    //         ...books,
    //         {
    //             title: title,
    //             lang: lang,
    //             publisher: publisher,
    //             author: author
    //         }
    //     ]);
        
    //     e.preventDefault();
    // };
  return (
    <div class="container">

        <form >
            <div class="mb-3 d-flex ">
                <label for="" class="form-label mx-5" >Title:</label>
                <input onChange={(a)=>setTitle(a.target.value)}
                    type="text"
                    class="form-control"               />
           
            </div>
            <p>Test para {title} </p>
            <div class="mb-3 d-flex">
                <label for="" class="form-label mx-5">Language:</label>
                <input onChange={(a)=>setLang(a.target.value)}
                    type="text"
                    class="form-control"   />
                      <p>Test para {lang} </p>
           
            </div>
            <div class="mb-3 d-flex">
                <label for="" class="form-label mx-5">Publisher:</label>
                <input onChange={(a)=>setPubli(a.target.value)}
                    type="text"
                    class="form-control"/>
                      <p>Test para {publisher} </p>
           
            </div>
            <div class="mb-3 d-flex">
                <label for="" class="form-label mx-5">Author:</label>
                <input onChange={(a)=>setAuthor(a.target.value)}
                    type="text"
                    class="form-control" />
                      <p>Test para {author} </p>
           
            </div>
        <div className='d-flex justify-content-around my-5'>
            <button onClick={AddBook}
                type="submit"
                class="btn btn-primary"
            >
                Add
            </button>
            <button  onClick={EditBook}
                type="button"
                class="btn btn-primary"
            >
                Edit
            </button>
            <button
                type="button"
                class="btn btn-primary"
            >
                Delete
            </button>
            <button
                type="button"
                class="btn btn-primary"
            >
                Search
            </button>
        </div>
  
        </form>

        <div
            class="table-responsive"
        >
            <table
                class="table table-striped"
            >
                <thead>
                    <tr>
                        <th scope="col">Title</th>
                        <th scope="col">Language</th>
                        <th scope="col">Publisher</th>
                        <th scope="col">Author</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        books.map(i=>{
                            return(
                                <tr>
                                    <td>{i.title}</td>
                                    <td>{i.lang}</td>
                                    <td>{i.publisher}</td>
                                    <td>{i.author}</td>

                                </tr>
                            )
                        })
                    }
                
                </tbody>
            </table>
        </div>
        
      
    </div>
  )
}
