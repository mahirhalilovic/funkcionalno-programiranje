module DBStore

open Microsoft.Data.Sqlite

module Types =
    type Item = {
        Id : int64;
        Name : string;
        Quantity : int64;
        Price : double
    }

module Connection =
    let makeConnectionString (filename : string) = "Data Source=./" + filename
    let makeConnection = new SqliteConnection(makeConnectionString "Inventory.db")

module Queries =
    let connection = Connection.makeConnection
    connection.Open()

    let CreateSchema () = 
        let cmd = connection.CreateCommand()
        cmd.CommandText <- """
            CREATE TABLE IF EXISTS ItemInventory;

            CREATE TABLE Items (
                id INTEGER PRIMARY KEY NOT NULL,
                name VARCHAR(255) NOT NULL,
                quantity INTEGER NOT NULL,
                price REAL NOT NULL
            );
        """

        cmd.ExecuteNonQuery() |> ignore
        ()

    
    let InsertItem (item : Types.Item) : unit =
        let cmd = connection.CreateCommand()
        cmd.CommandText <- """
            INSERT INTO Items(name, quantity, price) VALUES (@Name, @Quantity, @Price)
        """
        cmd.Parameters.AddWithValue("$Name", item.Name) |> ignore
        cmd.Parameters.AddWithValue("$Quantity", item.Quantity) |> ignore
        cmd.Parameters.AddWithValue("$Price", item.Price) |> ignore
        cmd.ExecuteNonQuery() |> ignore
        ()


    let SelectItem (id : int64) : Types.Item =
        let cmd = connection.CreateCommand()
        cmd.CommandText <- """
            SELECT * FROM Items WHERE id = @id;
        """
        cmd.Parameters.AddWithValue("$id", id) |> ignore
        let reader = cmd.ExecuteReader()
        reader.Read() |> ignore
        let id = reader.GetInt64(0)
        let name = reader.GetString(1)
        let qty = reader.GetInt64(2)
        let pr = reader.GetDouble(3)
        let item : Types.Item = {Id = id; Name = name; Quantity = qty; Price = pr}
        item