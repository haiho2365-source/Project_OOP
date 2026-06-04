using Project_OOP;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class PublicationManager
{
    private List<Publication> _postList;
    private string _connectionString = "Server=.;Database=Project_Desktop;Trusted_Connection=True;TrustServerCertificate=True;";

    public PublicationManager()
    {
        this._postList = new List<Publication>();
        LoadFromDatabase();
    }

    private void LoadFromDatabase()
    {
        using (SqlConnection conn = new SqlConnection(_connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Publications", conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["Id"].ToString();
                        string title = reader["Title"].ToString();
                        DateTime publishDate = Convert.ToDateTime(reader["PublishDate"]);
                        bool isApproved = Convert.ToBoolean(reader["IsApproved"]);
                        string content = reader["Content"].ToString();
                        string videoUrl = reader["VideoUrl"].ToString();
                        string type = reader["Type"].ToString();

                        Publication p = null;
                        if (type == "DailyNews")
                        {
                            int trend = reader["TrendLevel"] != DBNull.Value ? Convert.ToInt32(reader["TrendLevel"]) : 0;
                            p = new DailyNews(id, title, publishDate, trend);
                        }
                        else if (type == "BreakingNews")
                        {
                            int trend = reader["TrendLevel"] != DBNull.Value ? Convert.ToInt32(reader["TrendLevel"]) : 0;
                            p = new BreakingNews(id, title, publishDate, trend);
                        }
                        else if (type == "VideoReport")
                        {
                            string resolution = reader["Resolution"].ToString();
                            p = new VideoReport(id, title, publishDate, 0, resolution);
                        }
                        else if (type == "WeeklyMagazine")
                        {
                            string author = reader["Author"].ToString();
                            p = new WeeklyMagazine(id, title, publishDate, author);
                        }

                        if (p != null)
                        {
                            p.Content = content;
                            p.VideoUrl = videoUrl;
                            p.IsApproved = isApproved;
                            _postList.Add(p);
                        }
                    }
                }
            }
        }
    }

    public void AddPost(Publication post)
    {
        this._postList.Add(post);
        using (SqlConnection conn = new SqlConnection(_connectionString))
        {
            conn.Open();
            string query = "INSERT INTO Publications (Id, Title, PublishDate, IsApproved, Content, VideoUrl, Type, TrendLevel, Resolution, Author) VALUES (@Id, @Title, @PublishDate, @IsApproved, @Content, @VideoUrl, @Type, @TrendLevel, @Resolution, @Author)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", post.Id);
                cmd.Parameters.AddWithValue("@Title", post.Title);
                cmd.Parameters.AddWithValue("@PublishDate", post.PublishDate);
                cmd.Parameters.AddWithValue("@IsApproved", post.IsApproved);
                cmd.Parameters.AddWithValue("@Content", post.Content ?? "");
                cmd.Parameters.AddWithValue("@VideoUrl", post.VideoUrl ?? "");

                string type = "DailyNews";
                object trend = DBNull.Value;
                object resolution = DBNull.Value;
                object author = DBNull.Value;

                if (post is BreakingNews b) { type = "BreakingNews"; trend = b.TrendLevel; }
                else if (post is DailyNews d) { type = "DailyNews"; trend = d.TrendLevel; }
                else if (post is VideoReport v) { type = "VideoReport"; resolution = v.Resolution; }
                else if (post is WeeklyMagazine w) { type = "WeeklyMagazine"; author = w.Author; }

                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@TrendLevel", trend);
                cmd.Parameters.AddWithValue("@Resolution", resolution);
                cmd.Parameters.AddWithValue("@Author", author);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public bool UnapprovePost(string id)
    {
        for (int i = 0; i < this._postList.Count; i = i + 1)
        {
            if (this._postList[i].Id == id)
            {
                this._postList[i].IsApproved = false;
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Publications SET IsApproved = 0 WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
        }
        return false;
    }

    public bool ApprovePost(string id)
    {
        for (int i = 0; i < this._postList.Count; i = i + 1)
        {
            if (this._postList[i].Id == id)
            {
                this._postList[i].IsApproved = true;
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Publications SET IsApproved = 1 WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
        }
        return false;
    }

    public bool RemovePost(string id)
    {
        for (int i = 0; i < this._postList.Count; i = i + 1)
        {
            if (this._postList[i].Id == id)
            {
                this._postList.RemoveAt(i);
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Publications WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
        }
        return false;
    }

    public List<Publication> GetPostList()
    {
        return this._postList;
    }
}