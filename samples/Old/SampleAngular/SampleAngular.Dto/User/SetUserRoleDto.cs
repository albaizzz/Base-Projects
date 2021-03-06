// Copyright (c) Polyrific, Inc 2018. All rights reserved.

using System.ComponentModel.DataAnnotations;

namespace SampleAngular.Dto
{
    public class SetUserRoleDto
    {
        /// <summary>
        /// Id of the user
        /// </summary>
        [Required]
        public int UserId { get; set; }

        /// <summary>
        /// Name of the role
        /// </summary>
        public string RoleName { get; set; }
    }
}