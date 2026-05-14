using Project_OOP;
using System;
using System.Collections.Generic;

public class PublicationManager
{
    private List<Publication> _postList;

    public PublicationManager()
    {
        this._postList = new List<Publication>();

        SeedData();
    }

    private void SeedData()
    {
        DailyNews tin1 = new DailyNews("T001", "Bản tin thời sự Bắt khẩn cấp cựu tuyển thủ hành hung côn đồ trọng tài ngay trên sân cỏ", DateTime.Now, 5);
        tin1.Content = "Bản tin thời sự";
        tin1.IsApproved = false;
        tin1.VideoUrl = "https://drive.google.com/file/d/1B6bcWgvoB-lRyWiZkXUMGNa63U5N4Lty/view?usp=drive_link";
        this._postList.Add(tin1);

        DailyNews tin4 = new DailyNews("T002", "Bản tin thời sự sáng Thông tin cực nóng kẻ cướp tiệm vàng mùng 1 Tết đang được cả nước truy tìm", DateTime.Now, 5);
        tin4.Content = "Bản tin thời sự";
        tin4.IsApproved = true;
        tin4.VideoUrl = "https://drive.google.com/file/d/1KWhJi_monf1txD-grc8HkXxmQN6SdTcT/view?usp=drive_link";
        this._postList.Add(tin4);

        DailyNews tin5 = new DailyNews("T003", "Làn sóng A.I thúc đẩy ngành bán dẫn | Thế giới 24h", DateTime.Now, 5);
        tin5.Content = "Bản tin thời sự";
        tin5.IsApproved = true;
        tin5.VideoUrl = "https://drive.google.com/file/d/1ojpumkFa4VstLPsrjJjnxGy5phPzpiTs/view?usp=drive_link";
        this._postList.Add(tin5);

        VideoReport tin2 = new VideoReport("V001", "Bóc trần chiêu gọi hồn, áp vong, vòi tiền của bà thầy bói ở Thái Bình | VTV24", DateTime.Now, 100.0, "1080p");
        tin2.Content = "Nội dung video phóng sự...";
        tin2.VideoUrl = "https://drive.google.com/file/d/1yGXliJYZcV9g1ph8NKseqdNK45VszxHH/view?usp=drive_link";
        tin2.IsApproved = true;
        this._postList.Add(tin2);

        VideoReport tin6 = new VideoReport("V002", "Cảnh báo tình trạng bắt cóc tống tiền người nước ngoài | VTV Times", DateTime.Now, 100.0, "1080p");
        tin6.Content = "Nội dung video phóng sự...";
        tin6.VideoUrl = "https://drive.google.com/file/d/1TXlVXSnOG3BgE5dw0Lm7bcfsilidsAd6/view?usp=drive_link";
        tin6.IsApproved = true;
        this._postList.Add(tin6);

        BreakingNews tin3 = new BreakingNews("B002", "CẢNH BÁO NÓNG “Bom nước” sắp vỡ tung “uy hiếp” Bắc Bộ, Hà Nội đặc biệt chú ý 3 giờ tới  VietNamNet", DateTime.Now, 10);
        tin3.Content = "Tin khẩn cấp.";
        tin3.VideoUrl = "https://drive.google.com/file/d/13JAVuJSy7_-BzATK2GGiJbeTM_UULDd2/view?usp=drive_link";
        tin3.IsApproved = false;
        this._postList.Add(tin3);

        BreakingNews tin7 = new BreakingNews("B001", "TIN BÃO KHẨN CẤP (Cơn bão số 11) 12h ngày 5/10", DateTime.Now, 10);
        tin7.Content = "Tin khẩn cấp.";
        tin7.VideoUrl = "https://drive.google.com/file/d/1gsiMx_wHCl2OHnK4SjwP4a5FmCBFFNrQ/view?usp=drive_link";
        tin7.IsApproved = true;
        this._postList.Add(tin7);
    }

    public void AddPost(Publication post)
    {
        this._postList.Add(post);
    }

    public bool UnapprovePost(string id)
    {
        for (int i = 0; i < this._postList.Count; i = i + 1)
        {
            if (this._postList[i].Id == id)
            {
                this._postList[i].IsApproved = false;
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
                return true;
            }
        }
        return false;
    }

    public void ShowAllPosts()
    {
        for (int i = 0; i < this._postList.Count; i = i + 1)
        {
            this._postList[i].DisplayContent();
        }
    }

    public List<Publication> GetPostList()
    {
        return this._postList;
    }

    public void SetPostList(List<Publication> loadedList)
    {
        this._postList = loadedList;
    }

    public bool UpdatePost(string id, string newTitle, string content, string videoUrl, DateTime publishDate, string extraData)
    {
        for (int i = 0; i < this._postList.Count; i = i + 1)
        {
            if (this._postList[i].Id == id)
            {
                this._postList[i].Title = newTitle;
                this._postList[i].Content = content;
                this._postList[i].VideoUrl = videoUrl;
                this._postList[i].PublishDate = publishDate;

                Publication p = this._postList[i];

                if (p is BreakingNews)
                {
                    BreakingNews breaking = (BreakingNews)p;
                    int newTrend;
                    if (int.TryParse(extraData, out newTrend) == true)
                    {
                        breaking.TrendLevel = newTrend;
                    }
                }
                else if (p is DailyNews)
                {
                    DailyNews daily = (DailyNews)p;
                    int newTrend;
                    if (int.TryParse(extraData, out newTrend) == true)
                    {
                        daily.TrendLevel = newTrend;
                    }
                }
                else if (p is VideoReport)
                {
                    VideoReport video = (VideoReport)p;
                    video.Resolution = extraData;
                }
                else if (p is WeeklyMagazine)
                {
                    WeeklyMagazine magazine = (WeeklyMagazine)p;
                    magazine.Author = extraData;
                }

                return true;
            }
        }
        return false;
    }
}