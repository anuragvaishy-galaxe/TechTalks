using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechTalks.BusinessLayer.Interface
{
    public interface IBusiness
    {
        void AddPost();
        void UpdatePost();
        object GetPostById(int postId);
        bool DeletePostById(int postId);
    }
}
