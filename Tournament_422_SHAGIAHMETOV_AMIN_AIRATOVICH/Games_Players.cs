//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tournament_422_SHAGIAHMETOV_AMIN_AIRATOVICH
{
    using System;
    using System.Collections.Generic;
    
    public partial class Games_Players
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Games_Players()
        {
            this.Match_History = new HashSet<Match_History>();
            this.Order_Players = new HashSet<Order_Players>();
            this.Player_Achivments = new HashSet<Player_Achivments>();
            this.Players_Erning = new HashSet<Players_Erning>();
            this.Toutnament_Result = new HashSet<Toutnament_Result>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Id_Game { get; set; }
        public Nullable<int> Id_Players { get; set; }
        public Nullable<int> Reiting { get; set; }
        public Nullable<int> Game_Count { get; set; }
        public Nullable<int> Count_Win { get; set; }
        public Nullable<int> Count_Lose { get; set; }
        public Nullable<int> Role_Id { get; set; }
    
        public virtual Game Game { get; set; }
        public virtual Players Players { get; set; }
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Match_History> Match_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Players> Order_Players { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Player_Achivments> Player_Achivments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Players_Erning> Players_Erning { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Toutnament_Result> Toutnament_Result { get; set; }
    }
}
