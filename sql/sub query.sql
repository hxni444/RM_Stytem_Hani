select * from sales
select * from sales where qty = (select max(qty) from sales)
select * from stores
select * from sales where stor_id = (select stor_id from stores where stor_name = 'Bookbeat') --miltiple table
select * from sales where stor_id in (select stor_id from stores where stor_name in ('Bookbeat','Eric the Read Books','Fricative Bookshop')) --miltiple table using IN
