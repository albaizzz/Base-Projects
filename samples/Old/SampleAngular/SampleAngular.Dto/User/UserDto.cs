// Copyright (c) Polyrific, Inc 2018. All rights reserved.

namespace SampleAngular.Dto
{
    public class UserDto
    {
        public int Id { get; set; }

        /// <summary>
        /// Username of the user
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// First Name of the user
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name of the user
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email address of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Is user active?
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Role of the user
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Is user email confirmed?
        /// </summary>
        public bool EmailConfirmed { get; set; }
    }
}
